# ErcJul.Tailwind - tailwindcss generate tool

This package provides C# tooling support for generating CSS from `tailwindConfig.css` files in `.csproj` projects.

## Simple example

To add a `tailwindConfig.css` file to a project edit the project’s `.csproj` file and add an item group with a `<TailWindCss>` element that refers to the `tailwindConfig.css` file, e.g.

```xml
<ItemGroup>
    <TailWindCss Include="css\app.css" OutputPath="wwwroot/app1.css"/>
</ItemGroup
