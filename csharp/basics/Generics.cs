public class MyGenericClass<T> // 'T' is a placeholder for any type.
{
    private T item;
    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}
