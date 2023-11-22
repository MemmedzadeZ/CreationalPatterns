namespace CreationalPatterns.FactoryMethod;

public class WebDialog : Dialog
{

    public Button createButton()
    {
        return new HTML_Button();
    }
}
