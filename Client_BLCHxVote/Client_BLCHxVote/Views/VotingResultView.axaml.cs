using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Client_BLCHxVote.Views;

public partial class VotingResultView : UserControl
{
    public VotingResultView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}