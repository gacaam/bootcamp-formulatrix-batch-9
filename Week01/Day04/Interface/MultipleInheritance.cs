public interface IAnimal {
	void Walk();
	void Breath();
	void Sound();
}
public interface IJump {
	void Jump();
}
public abstract class LandAnimal : IAnimal {
	public void Walk() {
		//...
	}
	public void Breath() {
		//...
	}
	public abstract void Sound();
}
public class Cat : LandAnimal, IJump {
	public override void Sound() {
		//...
	}
	public void Jump() {
		//...
	}
}
