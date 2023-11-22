namespace CreationalPatterns.FactoryMethod; 



public class Dialog
{
    public void render() { }

    public Button creatButton()
    {
        return new Windows_Button();
       
    }
}
