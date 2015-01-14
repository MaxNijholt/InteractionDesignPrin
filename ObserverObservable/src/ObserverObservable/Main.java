package ObserverObservable;

public class Main {

	public Main()
	{
		ObservableValue ov = new ObservableValue(0);
		TextObserver to = new TextObserver(ov);
		ov.addObserver(to);
		ov.setValue(10);
		ov.setValue(9);
	}

	public static void main(String [] args)
	{
		Main m = new Main();
	}
}
