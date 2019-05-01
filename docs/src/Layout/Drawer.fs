module Layout.Drawer

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

open App.Types
open Global
open Elmish.React.Common

let drawerStyles : IStyles list =
    [
        Styles.Root [
            Width 250
        ]
        Styles.Paper [
            Width 250
        ]
    ]


type AppDrawerProps =
    abstract member isLanding: bool with get,set
    abstract member currentPage: Page with get,set
    abstract member menuOpen: bool with get,set
    abstract member dispatch: (Msg->unit) with get,set
    inherit IClassesProps


let drawer (props : AppDrawerProps) =
    nav [] [
        yield hidden [
            LgUp (not props.isLanding)
            Implementation HiddenImplementation.Js
        ] [
            swipeableDrawer [
                DrawerProp.Variant DrawerVariant.Temporary
                MaterialProp.Open props.menuOpen
                MaterialProp.OnOpen (fun _ -> OpenMenu true |> props.dispatch)
                MaterialProp.OnClose (fun _ -> OpenMenu false |> props.dispatch)
                ModalProps [ KeepMounted true ]
                Classes [
                    ClassNames.Paper !!props.classes?paper
                ]
            ] [
                lazyView2 Layout.Menu.view props.currentPage props.dispatch ]
        ]
        if not props.isLanding then
            yield hidden [
                MdDown true
                Implementation HiddenImplementation.Js
            ] [
                drawer [
                    DrawerProp.Variant DrawerVariant.Permanent
                    MaterialProp.Open true
                    Class !!props.classes?root
                    Classes [
                        ClassNames.Paper !!props.classes?paper
                    ]
                ] [
                    lazyView2 Layout.Menu.view props.currentPage props.dispatch ]
            ]
    ]

let drawerWithStyles = withStyles (StyleType.Styles drawerStyles) [] drawer

let view (model : Model) dispatch =
    let props = createEmpty<AppDrawerProps>
    props.currentPage <- model.currentPage
    props.isLanding <- model.isLanding
    props.menuOpen <- model.menuOpen
    props.dispatch <- dispatch
    ReactElementType.create drawerWithStyles props []
