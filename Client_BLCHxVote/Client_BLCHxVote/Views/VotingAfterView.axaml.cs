using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Client_BLCHxVote.Views;

public partial class VotingAfterView : UserControl
{
    public VotingAfterView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}