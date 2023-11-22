namespace StructuralPatterns.ProxyMethod;

public class Proxy
{

    public Service? realSetvise { get; set; }
	public Proxy(Service s) { }

	public void checkAccess() { }
	public void operation() { }

	
}
