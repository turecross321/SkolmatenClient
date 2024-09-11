namespace SkolmatenApi.Attributes;

public class UrlParameterAttribute(string name): Attribute
{
    public string Name { get; } = name;
}