# WPF.Bootstrap
A Bootstrap Theme for WPF

## How to Use

`Install-Package WPF.Bootstrap`

Put the following code in your App.xaml or MainWindow.xaml or any other window which use the resourse, for example, in `App.xaml`

    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="/WPF.Bootstrap;component/Themes/Default.xaml"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
    
Now you can use the controls, for example:

        <bootstrap:BootstrapPanel Margin="10" Type="Default" Header="Default Panel">
            <TextBlock>content</TextBlock>
            <bootstrap:BootstrapPanel.Footer>
                <TextBlock>footer</TextBlock>
            </bootstrap:BootstrapPanel.Footer>
        </bootstrap:BootstrapPanel>
        
Remember to add `xmlns:bootstrap="http://github.com/scheshan/bootstrap"`
