# nito-mvvm-accordion-xamarin

This sample demonstrates how to use the Nito.MVVM pattern together with Syncfusion's SfAccordion control in a Xamarin.Forms project. The goal of the repository is to show a simple, practical pattern where an accordion is data-driven from a ViewModel (via BindableLayout.ItemsSource) and each AccordionItem is rendered from a DataTemplate.

The code in this repository is organized as a small Xamarin.Forms solution with Android, iOS and UWP projects, and a shared .NET Standard library that contains the UI and ViewModel. The accordion is provided by Syncfusion's Xamarin Accordion control (SfAccordion).

For more details about the control and its options, refer to the official User Guide:

- [Getting Started with Xamarin Accordion (SfAccordion)](https://help.syncfusion.com/xamarin/accordion/getting-started)


**KB Link:** **[View document in Syncfusion Xamarin Knowledge base](https://www.syncfusion.com/kb/12204/how-to-use-nito-mvvm-in-xamarin-forms-accordion-sfaccordion)**


## What this sample shows

- How to bind an `SfAccordion` to a ViewModel collection using `BindableLayout.ItemsSource`.
- How to define an `AccordionItem` `Header` and `Content` inside a `DataTemplate`.
- How to trigger data loading via a `LoadDataCommand` exposed from the ViewModel.

## XAML

The accordion is bound to a view-model collection (`Info`) using `BindableLayout.ItemsSource`. Below is the relevant XAML snippet extracted from `Views/MainPage.xaml` in this repository:

```xml
<ContentPage.BindingContext>
    <local:ItemInfoRepository/>
</ContentPage.BindingContext>

<ContentPage.Content>
    <StackLayout>
        <Button Text="Load Accordion" Command="{Binding LoadDataCommand}" HeightRequest="50"/>
        <accordion:SfAccordion x:Name="accordion" BindableLayout.ItemsSource="{Binding Info}" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" ExpandMode="SingleOrNone">
            <BindableLayout.ItemTemplate>
                <DataTemplate>
                    <accordion:AccordionItem>
                        <accordion:AccordionItem.Header>
                            <Grid>
                                <Label TextColor="#495F6E" Text="{Binding Name}" VerticalOptions="Center" HorizontalOptions="Center" HeightRequest="50" VerticalTextAlignment="Center"/>
                            </Grid>
                        </accordion:AccordionItem.Header>
                        <accordion:AccordionItem.Content>
                            <Grid BackgroundColor="#e8e8e8" Padding="5,0,0,0">
                                <Label Text="{Binding Description}" VerticalOptions="Center"/>
                            </Grid>
                        </accordion:AccordionItem.Content>
                    </accordion:AccordionItem>
                </DataTemplate>
            </BindableLayout.ItemTemplate>
        </accordion:SfAccordion>
    </StackLayout>
</ContentPage.Content>
```

## How it works

- SfAccordion: provides a list of expandable items where at most one item is expanded at a time when `ExpandMode="SingleOrNone"` is used.
- BindableLayout.ItemsSource: drives item generation from the ViewModel collection named `Info`.
- DataTemplate: defines each `AccordionItem` with a `Header` (shows `Name`) and `Content` (shows `Description`).
- LoadDataCommand: the `Button` calls `LoadDataCommand` on the page BindingContext to populate or refresh the `Info` collection at runtime.


##### Conclusion
I hope you enjoyed learning about how to use Nito.MVVM in Xamarin.Forms Accordion (SfAccordion).

You can refer to our  [Xamarin.Forms Accordion feature tour](https://www.syncfusion.com/xamarin-ui-controls/xamarin-accordion) page to know about its other groundbreaking feature representations and [documentation](https://help.syncfusion.com/xamarin/accordion/getting-started), and how to quickly get started for configuration specifications. You can also explore our [Xamarin.Forms Accordion example](https://www.syncfusion.com/demos/xamarin) to understand how to create and manipulate data.

For current customers, you can check out our Document Processing Libraries from the [License and Downloads](https://www.syncfusion.com/account/login) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads) to check out our controls.

If you have any queries or require clarifications, please let us know in the comments section below. You can also contact us through our [support forums](https://www.syncfusion.com/forums) or [Direct-trac](https://support.syncfusion.com/create). We are always happy to assist you!


