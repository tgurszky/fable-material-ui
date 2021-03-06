# StepIcon

<p class="description">The API documentation of the StepIcon React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.stepIcon (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Active</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Whether this step is active. |
| <span class="prop-name">MaterialProp.Error</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Mark the step as failed. |
| <span class="prop-name required">MaterialProp.Icon *</span> | <span class="prop-type">ReactElement</span> |   | The icon displayed by the step label. |
| <span class="prop-name">StepProp.Completed</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Mark the step as completed. Is passed to child components. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Text</span> | Styles applied to the SVG text element.
| <span class="prop-name">ClassNames.Active</span> | Styles applied to the root element if `active={true}`.
| <span class="prop-name">ClassNames.Completed</span> | Styles applied to the root element if `completed={true}`.
| <span class="prop-name">ClassNames.Error</span> | Styles applied to the root element if `error={true}`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/StepIcon/StepIcon.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiStepIcon`.

<!--## Demos-->

<!--- [Steppers](/demos/steppers/)-->

