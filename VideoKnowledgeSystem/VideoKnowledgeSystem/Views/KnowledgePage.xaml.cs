using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using VideoKnowledgeSystem.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace VideoKnowledgeSystem.Views
{
    public sealed partial class KnowledgePage : Page
    {
        public KnowledgePage()
        {
            InitializeComponent();

            KnowledgeListView.ItemsSource = new[]
            {
                new KnowledgeItem
                {
                    Id=Guid.NewGuid(),
                    Timestamp=TimeSpan.FromMinutes(2),
                    FrameType="Slide",
                    Text="Neural Networks"
                },
                new KnowledgeItem
                {
                    Id=Guid.NewGuid(),
                    Timestamp=TimeSpan.FromMinutes(5),
                    FrameType="Chart",
                    Text="Accuracy Results"
                }
            };
        }
    }
}
