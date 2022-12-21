namespace ClothingStore.Application.Common.Exceptions;

internal class NotFoundException : Exception
{
    public NotFoundException(string name, object key) : base($"Entity {name.ToUpper()} with id {key} not found")
    {
    }
}