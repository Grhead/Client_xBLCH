using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Client_BLCHxVote.Views;

public partial class VotingStartView : UserControl
{
    public VotingStartView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}