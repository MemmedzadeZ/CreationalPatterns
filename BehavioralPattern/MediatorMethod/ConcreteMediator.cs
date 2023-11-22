using System.Xml.Serialization;

namespace BehavioralPattern.MediatorMethod;

public class ConcreteMediator:Mediator
{

    private Mediator? componentA { get; set; }
    private Mediator? componentB { get; set; }
    private Mediator? componentC { get; set; }
    private Mediator? componentD { get; set; }


   public void reactOnA() { }
    public void reactOnB() { }
    public void reactOnC() { }
    public void reactOnD() { }


    public void notify(Mediator sender)
    {
        if(sender == componentA)
        {
            reactOnA();
        }

        if (sender == componentB)
        {
            reactOnB();
        }
        if (sender == componentC)
        {
            reactOnC();
        }
        if (sender == componentD)
        {
            reactOnD();
        }
    }

}
