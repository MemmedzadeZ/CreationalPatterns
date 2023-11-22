namespace CreationalPatterns.FactoryMethod; 
public class WindowsDialog :Dialog
{

    public Button createButton()
    {
        return new Windows_Button();
    }
}
