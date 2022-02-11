namespace CM.ObjectCreation
{
	public interface IObjectCreator<T>
	{
		T CloneObject(T clonableObject);
		void DestroyObject(T destroyableObject);
	}
}