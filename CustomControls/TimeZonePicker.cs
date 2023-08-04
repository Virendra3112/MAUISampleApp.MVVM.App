using Microsoft.Maui.Controls.Shapes;


namespace MAUISampleApp.MVVM.CustomControls
{
    public class TimeZonePicker : VerticalStackLayout
    {
        public TimeZonePicker()
        {
            AddContent();
        }

        private void AddContent()
        {
            Add(new Label
            {
                Text = "Pick a time zone...",
                FontSize = 14
            });

            Add(new Border
            {
                StrokeShape = new Rectangle(),
                Padding = 2,
                Content = GetCollectionView()
            });
        }

        private CollectionView GetCollectionView()
        {
            var view = new CollectionView
            {
                //ItemsSource = TODO,
                //ItemTemplate = TODO,
                MaximumHeightRequest = 200,
                SelectionMode = SelectionMode.Single
            };

            ((LinearItemsLayout)view.ItemsLayout).ItemSpacing = 10;

            return view;
        }
    }
}
