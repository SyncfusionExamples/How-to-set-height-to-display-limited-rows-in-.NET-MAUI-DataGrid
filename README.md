# How to set height to display limited rows in .NET MAUI DataGrid

In this article, we will show you how to set the height of the` Syncfusion .NET MAUI DataGrid (SfDataGrid)` to display only a limited number of rows while retaining scrolling support for the remaining records. This approach is useful when the DataGrid is hosted inside layouts with limited screen space, dashboards, forms, or data entry pages where displaying all rows is unnecessary. By calculating the grid height based on the header row and a fixed number of data rows, the DataGrid can be constrained to a predictable size without affecting its data binding capabilities.

The sample binds the DataGrid to an `ObservableCollection<OrderInfo>` through an `OrderInfoRepository`. When the DataGrid finishes loading, the height is dynamically calculated using the `HeaderRowHeight` and `RowHeight` properties to ensure exactly five records are visible at a time. Any additional records can still be accessed through the grid's built-in scrolling behavior.

## xaml

```xml
<ContentPage.BindingContext>
    <local:OrderInfoRepository />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="dataGrid"
                       DataGridLoaded="dataGrid_Loaded"
                       ItemsSource="{Binding OrderInfoCollection}">
</syncfusion:SfDataGrid>
```

The page uses an `OrderInfoRepository` as its BindingContext and binds the DataGrid's `ItemsSource` to the `OrderInfoCollection`. The `DataGridLoaded` event is used to adjust the grid height after the control has been initialized and its layout properties are available.

## C#

The following code calculates the DataGrid height so that only five rows are visible.

```csharp
private void dataGrid_Loaded(object sender, EventArgs e)
{
    dataGrid.MinimumHeightRequest = 0;
    dataGrid.HeightRequest = dataGrid.HeaderRowHeight + dataGrid.RowHeight * 5;
}
```

In this example, `MinimumHeightRequest` is set to `0` to allow the DataGrid to resize freely. The `HeightRequest` is then calculated using the height of the header row plus the height of five data rows. This ensures that only five records are displayed, regardless of the total number of items available in the bound collection.

## Data Source

The DataGrid is populated using an `ObservableCollection<OrderInfo>` provided by the `OrderInfoRepository` class.

```csharp
public ObservableCollection<OrderInfo> OrderInfoCollection
{
    get { return orderInfo; }
    set { this.orderInfo = value; }
}
```

The repository generates sample order records containing customer information, order identifiers, shipping locations, and quantities. Because the collection is observable, any additions or removals can automatically be reflected in the DataGrid.

## Benefits of Limiting Visible Rows

- Creates a compact grid layout suitable for dashboards and forms.
- Prevents the DataGrid from occupying excessive screen space.
- Maintains built-in scrolling for accessing additional records.
- Provides a consistent UI regardless of dataset size.
- Dynamically adjusts based on the configured row and header heights.
- Works with manually generated or auto-generated columns.

## Try It

1. Run the application.
2. Observe that the DataGrid is populated with order records from the repository.
3. Notice that only five rows are visible initially.
4. Scroll within the DataGrid to access the remaining records.
5. Modify the multiplier value in the `HeightRequest` calculation to display more or fewer rows.

##### Conclusion

I hope you enjoyed learning about how to set the height to display a limited number of rows in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!