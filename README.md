# ErcJul.Tailwind - tailwindcss generate tool

This package provides C# tooling support for generating CSS from `tailwindConfig.css` files in `.csproj` projects.

## Available project options

| Name                  | Description                |
|-----------------------|----------------------------|
| TailwindCli_ToolsOs   | TailwindCli exec for os    |
| TailwindCli_ToolsCpu  | TailwindCli exec for cpu   |
| TailwindCli_ToolsPath | TailwindCli exec dir path  |
| TailwindCli_FullPath  | TailwindCli exec full path |

## Available options

| Name       | Default value             | Description                    |
|------------|---------------------------|--------------------------------|
| OutputPath | "obj/.../wwwroot/app.css" | the output file path           |
| Minify     | "False"                   | Optimize and minify the output |

## Simple example

To add a `tailwindConfig.css` file to a project edit the project’s `.csproj` file and add an item group with a
`<TailWindCss>` element that refers to the `tailwindConfig.css` file, e.g.

```xml

<ItemGroup>
    <TailWindCss Include="config\tailwindConfig.css" OutputPath="wwwroot\app.css" Minify="True"/>
</ItemGroup>
```