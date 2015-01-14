package ObserverObservable;

import java.util.Observer;
import java.util.Observable;
public class TextObserver implements Observer
{
	private ObservableValue ov = null;
	public TextObserver(ObservableValue ov)
	{
		this.ov = ov;
	}
	public void update(Observable obs, Object obj)
	{
		if (obs == ov)
		{
			System.out.println("I changed to: "+ov.getValue());
		}
	}
}