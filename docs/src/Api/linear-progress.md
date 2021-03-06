# LinearProgress

<p class="description">The API documentation of the LinearProgress React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.linearProgress (props : seq<IHTMLProp>) : ReactElement
```

## ARIA

If the progress bar is describing the loading progress of a particular region of a page,
you should use `aria-describedby` to point to the progress bar, and set the `aria-busy`
attribute to `true` on that region until it has finished loading.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">LinearProgressProp.Color</span> | <span class="prop-type">type&nbsp;LinearProgressColor&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Primary<br>&nbsp;&nbsp;&#124;&nbsp;Secondary<br></span> | <span class="prop-default">LinearProgressColor.Primary</span> | The color of the component. It supports those theme colors that make sense for this component. |
| <span class="prop-name">LinearProgressProp.Value</span> | <span class="prop-type">int</span> |   | The value of the progress indicator for the determinate and buffer variants. Value between 0 and 100. |
| <span class="prop-name">LinearProgressProp.ValueBuffer</span> | <span class="prop-type">int</span> |   | The value for the buffer variant. Value between 0 and 100. |
| <span class="prop-name">LinearProgressProp.Variant</span> | <span class="prop-type">type&nbsp;LinearProgressVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Determinate<br>&nbsp;&nbsp;&#124;&nbsp;Indeterminate<br>&nbsp;&nbsp;&#124;&nbsp;Buffer<br>&nbsp;&nbsp;&#124;&nbsp;Query<br></span> | <span class="prop-default">LinearProgressVariant.Indeterminate</span> | The variant to use. Use indeterminate or query when there is no progress value. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.ColorPrimary</span> | Styles applied to the root & bar2 element if `color="primary"`; bar2 if `variant-"buffer"`.
| <span class="prop-name">ClassNames.ColorSecondary</span> | Styles applied to the root & bar2 elements if `color="secondary"`; bar2 if `variant="buffer"`.
| <span class="prop-name">ClassNames.Determinate</span> | Styles applied to the root elements if `variant="determinate"`.
| <span class="prop-name">ClassNames.Indeterminate</span> | Styles applied to the root elements if `variant="determinate"`.
| <span class="prop-name">ClassNames.Buffer</span> | Styles applied to the root element if `variant="buffer"`.
| <span class="prop-name">ClassNames.Query</span> | Styles applied to the root element if `variant="query"`.
| <span class="prop-name">ClassNames.Dashed</span> | Styles applied to the additional bar element if `variant="buffer"`.
| <span class="prop-name">ClassNames.DashedColorPrimary</span> | Styles applied to the additional bar element if `variant="buffer"` & `color="primary"`.
| <span class="prop-name">ClassNames.DashedColorSecondary</span> | Styles applied to the additional bar element if `variant="buffer"` & `color="secondary"`.
| <span class="prop-name">ClassNames.Bar</span> | Styles applied to the layered bar1 & bar2 elements.
| <span class="prop-name">ClassNames.BarColorPrimary</span> | Styles applied to the bar elements if `color="primary"`; bar2 if `variant` not "buffer".
| <span class="prop-name">ClassNames.BarColorSecondary</span> | Styles applied to the bar elements if `color="secondary"`; bar2 if `variant` not "buffer".
| <span class="prop-name">ClassNames.Bar1Indeterminate</span> | Styles applied to the bar1 element if `variant="indeterminate or query"`.
| <span class="prop-name">ClassNames.Bar1Determinate</span> | Styles applied to the bar1 element if `variant="determinate"`.
| <span class="prop-name">ClassNames.Bar1Buffer</span> | Styles applied to the bar1 element if `variant="buffer"`.
| <span class="prop-name">ClassNames.Bar2Indeterminate</span> | Styles applied to the bar2 element if `variant="indeterminate or query"`.
| <span class="prop-name">ClassNames.Bar2Determinate</span> | Styles applied to the bar2 element if `variant="determinate"`.
| <span class="prop-name">ClassNames.Bar2Buffer</span> | Styles applied to the bar2 element if `variant="buffer"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/LinearProgress/LinearProgress.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiLinearProgress`.

<!--## Demos-->

<!--- [Progress](/demos/progress/)-->

