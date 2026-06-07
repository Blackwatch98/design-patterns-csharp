# Abstract Factory Pattern

The **Abstract Factory Pattern** is a creational design pattern that allows you to create families of related objects without specifying their concrete classes.

Instead of creating concrete objects directly in the application logic, object creation is moved to factory classes.

Each factory is responsible for creating a matching family of objects.

## Why use it?

The Abstract Factory Pattern is useful when your code needs to work with multiple related objects that should be used together.

It helps to:

- keep object creation logic separated from business logic,
- avoid creating concrete classes directly in client code,
- ensure that created objects belong to the same family,
- make it easier to switch between different object families,
- follow the Open/Closed Principle.

## Example

In this project, the Abstract Factory Pattern is shown using a UI rendering example.

The application can render UI components for different themes:

- `Windows`,
- `MacOS`.

Each theme has a family of related components:

- button,
- checkbox.

In the naive version, the renderer decides which concrete components should be created:

```csharp
var renderer = new UiRenderer();

var result = renderer.Render(UiTheme.Windows);
