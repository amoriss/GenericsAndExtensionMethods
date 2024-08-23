## 📦 Storage<T> Class and 🔧 ExtensionMethods

### 📦 Storage<T> Class

The `Storage<T>` class is a generic container designed to manage a collection of items where each item conforms to the `IStorable` interface. This class provides a way to store and manipulate objects of any type that implements `IStorable`.

#### Features

- **🔢 Generic Type Parameter:** `T` is a placeholder for any type that implements the `IStorable` interface. This constraint ensures type safety and guarantees that all items stored in the `Storage<T>` are storable.
- **🛠️ Constructors:**
  - **Default Constructor:** Initializes an empty `List<T>` to hold items.
  - **Parameterized Constructor:** Accepts a variable number of `T` items (using the `params` keyword) and adds them to the `Bin` list upon creation.
- **📋 Properties:**
  - **`Bin` Property:** A public property of type `List<T>` that stores the collection of items.
