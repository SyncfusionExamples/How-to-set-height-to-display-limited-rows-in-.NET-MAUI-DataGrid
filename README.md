# How to set height to display limited rows in .NET MAUI DataGrid 
This demo shows how to set the height to display a limited number of rows in the `Syncfusion .NET MAUI SfDataGrid`. By using this sample, you can fix the grid height so it displays a specific number of rows while preserving scrolling for any additional rows.

In the DataGrid’s `DataGridLoaded` event, set `MinimumHeightRequest` to 0 so the grid can shrink as needed, then compute and assign HeightRequest as the sum of the `HeaderRowHeight` and the desired number of row heights. The simple approach below assumes uniform row heights and provides a quick way to limit the visible rows while keeping the grid scrollable for remaining data.

```
private void dataGrid_Loaded(object sender, EventArgs e)
{
    dataGrid.MinimumHeightRequest = 0;
    dataGrid.HeightRequest = dataGrid.HeaderRowHeight + dataGrid.RowHeight * 5;
}
```
