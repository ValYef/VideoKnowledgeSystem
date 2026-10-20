using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using VideoKnowledgeSystem.Models;
using Windows.Storage.Pickers;
using WinRT.Interop;

namespace VideoKnowledgeSystem.Views
{
    public sealed partial class VideoPage : Page
    {
        private List<Video> _videos = new();
        public VideoPage()
        {
            InitializeComponent();
        }
        private async void SelectVideoButton_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker picker = new();

            picker.FileTypeFilter.Add(".mp4");
            picker.FileTypeFilter.Add(".avi");
            picker.FileTypeFilter.Add(".mov");
            picker.FileTypeFilter.Add(".mkv");

            var hwnd = WindowNative.GetWindowHandle(App.MainWindow);

            InitializeWithWindow.Initialize(picker, hwnd);

            var file = await picker.PickSingleFileAsync();

            if (file != null)
            {
                SelectedFileText.Text = file.Path;

                _videos.Add(new Video
                {
                    Id = new Guid(),
                    Name = file.Name,
                    FilePath = file.Path,
                    UploadedAt = DateTime.Now,
                    Status = ProcessingStatus.Uploaded
                });
                VideosListView.ItemsSource = null;
                VideosListView.ItemsSource = _videos;
            }
        }

        private void UploadVideoButton_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
