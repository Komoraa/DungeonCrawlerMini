using Core;

namespace UI.WinForms.Views;

public class RoomViewData
{
    public IRoom? Room { get; set; }
    public Point Position { get; set; }
    public bool IsVisible { get; set; }
    public bool IsVisited { get; set; }
}
