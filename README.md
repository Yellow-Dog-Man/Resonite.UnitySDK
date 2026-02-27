Resonite SDK for the Unity Editor. This will allow sending content from Unity Editor to Resonite easily.

Built on top of ResoniteLink: https://github.com/Yellow-Dog-Man/ResoniteLink

## ⚠️ Under heavy development! ⚠️
Currently this is under heavy development and isn't ready for use yet.

The code and structure is currently for quick prototyping & implementation phase and will likely move around after.

We do **NOT** accept PR's / issues at this point.

# Contributing
Contributions to this SDK are welcome! Converting content is a complex task and there and big part of this tool is giving more power to you - the community, to create new workflows and bring more content to Resonite. 

## Contributing component converters
- Improving existing converters
    - E.g. handling configurations / edge cases that aren't currently handled (or not handled well)
- Adding new converters
    - If there are components/behaviors that aren't converted at all - feel free to implement converters for them!
    - This should avoid adding 3rd party SDK's / dependencies to this though - if you want to do that, please consult us first by creating an Issue
    - At some point, we might suggest separating converters for 3rd party libraries into their own repo's and just linking them here
 
### How to PR component converter
If you want to contribute a new or improved comopnent converter, please ensure following:
- Adds sample content to the TestScene to test conversion with
- Make sure you test all other conversions in the TestScene that would be affected by your converter
- Ideally create issue for the converter first (if it does not exist)
    - You should be assigned to it first if your changes will be extensive to avoid clashes with other contributors 
- Make PR with the converter changes, TestScene changes

## Contributing material converters
- Improving existing converters
- Adding converters for new shaders
   - These are a bit easier to contribute, as they don't technically require new C# code for the shader
   - If possible, include the shader for testing in your PR
 
### How to PR material converter
- Ideally create issue for the shader, especially if it's a complex one
    - This will allow coordination with other contributors
- If possible, include the shader in the TestScene with various configurations (you can also add separate scene for it if it's extensive)
- If you're modifying existing converter, please test existing content with it to ensure your conversion doesn't break any of it
   - If needed, add more testing content for that shader please, so we can avoid regressions 
- Make PR with the material converter

## Other contributions
You can also contribute in a number of other areas! Check the Issues page for those. In short there are:

- UI / Workflow improvements
- General conversion bugfixes
- Quality of life improvements
- Help review & test PR's from other contributors 

For any larger reworks **please make sure there's an issue created first**. This will help prevent conflicts with changes from other contributors.

If you're not sure what to contribute, check the "help wanted" issues: https://github.com/Yellow-Dog-Man/Resonite.UnitySDK/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22help%20wanted%22

## When to fork instead
If you need to make changes to the SDK that would negatively affect general conversion, you should create a customized fork instead. This is for cases where you need to make some structural changes to help certain types of projects and content better, but that would break compatibility with other type of content.

Forking this SDK is perfectly fine! If there are popular forks with altered functionality, we can add links to those as well for people to explore.

You can also create private forks - e.g. if you want to use the SDK for your internal/private projects and use Resonite for prototyping/visualization. We have licensed this under MIT so you can use it for these use cases as well.

# How it works

## ResoniteLink
The Unity SDK communicates with Resonite through ResoniteLink - a websocket & JSON library that allows interacting with Resonite's data model from external applications. This library allows reading/writing Resonite data model - scene hierarchy, components and their fields. It also has functionality for importing various types of assets.

You can find the library here: https://github.com/Yellow-Dog-Man/ResoniteLink

Unless you need to modify or implement some lower level behaviors, you will likely not require to interact with this library and the protocol directly - it is abstracted away by the converter system.

## Bindings
Since Resonite has its own system of components and other types, the ResoniteLink library is used to create bindings for those. This is done by the "BindingsGenerator" project. This project walks all available component types in the Resonite instance it's connected to and creates binding "shells" for those - classes representing those components and their data model members.

This replicates the "data structure" of Resonite types without the actual behaviors. This is mostly 1:1 mapping. Some of the datatypes will be mapped to available Unity equivalents to make interacting with Unity's own API's, editor and other systems easier - e.g. float3 is mapped to Vector3 or float4x4 is mapped to Matrix4x4.

Apart from Components & SyncObjects which contain members, the bindings generation also replicates any other data types that are valid in data model - classes, interfaces, structs and enums. 

Generic constraints and implemented interfaces are replicated as well. This allows the bindings to use C#'s own type system to resolve majority of type constarints - e.g. components that have references that need to be specific interface, can reference the binding proxies naturally.

This way Resonite's C# type structure is replicated, without needing to reference FrooxEngine itself and its behaviors.

### Conversions
As part of the binding generation, code to collect values from those data proxies is also generated. This is what interfaces between the bindings and ResoniteLink, allowing to update Resonite's component data from the values in the generated binding.

### Primitives
The binding library contains explicitly implemented proxies for Resonite's primitives - vector, matrix, quaternion, color types and so on. Where possible, those are mapped to Unity's own datatypes to make conversions and interfacing with Unity's API easier. 

ResoniteLink doesn't provide a way to query those primitives - those need to be implemented and managed manually. However since primitives are very rarely added to data model, this approach should work fine.

**NOTE:** There are likely a few less commonly used primitives that aren't currently implemented. If you run into any, please make an issue!

### Enums
Enum types specifically are replicated with their values mapped. ResoniteLink provides API for this, to allow the values to be assigned from Unity easily, without having to guess which numeric values correspond to what.

### Component wrappers
For each Resonite component, the bindings generation creates a Unity Component wrapper. This allows attaching "Resonite Components" directly in the Unity game editor hierarchy and editing their values from the inspector UI.

**NOTE:** Since Unity doesn't support attaching generic components from the Editor UI, those can only be attached through code.

## Component Converters
While it's possible to fully construct a Resonite scene by attaching component wrappers to the hierarchy, this has a few issues:
- For existing Unity content, you'd need to manually map everything to appropriate Resonite components and essentially recreate it
- Those bindings don't provide any actual behaviors, so you'd have no visuals for what you're building

To solve this problem, the SDK has a feature called "Converters". Their responsibility is to take Unity Components that can be found in the scene and mapping them to Resonite's bindings. This system is also extensible - meaning you can add conversions for additional Unity components easily and define a custom logic to map them.

There are a few important points:
- The converter needs to specify which specific Unity component it converts
    - You can only specify one type - even if you need mix of components (e.g. MeshRenderer + MeshFilter) - this is the "entry point" for your converter
    - The scene conversion automatically attaches and updates converters - you don't need to worry about this process or attaching them manually
    - You can fetch other dependent components in your converter code (e.g. MeshRenderer converter will dynamically get MeshFilter)
- Converters can indirectly supress other converters
    - In some cases, certain Unity components are reused. For example TextMesh uses the MeshRenderer, which is also used with MeshFilter
    - The converter for TextMesh will supress the MeshRenderer converter, because it takes precedence
    - Each converter can define a function, which will be called with list of all components on given GameObject to be converted
    - If you don't want other converters handling any of the components in that list - remove them from the list
- The conversion should be written so it can handle both freshly attached components & updating existing conversion
    - Whenever the conversion function on the converter is called, you should do following:
        - Instantiate any Resonite bindings that are needed
        - Cleanup any Resonite bindings that are not needed
        - Update the state of the bindings to match the Unity component equivalents as close as possible
    - Think of each function call as "update Resonite Bindings from whatever current state is to whatever is needed to represent the current state of the Unity component that I'm responsible for converting"
        - It's perfectly OK to instantiate more than one Resonite Binding
        - Handle unsupported states and conversions gracefully - either try to convert it to closest possible equivalent
        - If not possible to convert at all - you can just delete bindings for that state
     
The Unity SDK will dynamically scan any available converters in your project before converting the scene - you don't need to do anything special to register them, other than deriving from the base class and specifying which type they convert.

## Material Converters
A similar system to component converters, the Unity SDK has material converter system. Its responsibility is to convert various materials into closest matches in Resonite. 

Since Resonite currently does not support custom shaders, it's not possible to convert those shaders directly. Instead, code needs to be written to handle those shaders and materials and map them to Resonite equivalents to match their look and behavior as closely as possible.

The mechanism is similar to component converters:
- You don't need to explicitly register them, the SDK will find them automatically - you do need to specify which shaders they convert though
- The conversion function needs to update the material representation to match the current state of the Unity material as closely as possible
- You can attach other components as well - e.g. driving behaviors or ProtoFlux to animate certain material properties
    - This lets you recreate some of shader effects programmatically
    - Look at the "TestPanningShader" for example on how this might be done

 There are two ways to specify which shaders your converter supports. You can support both or either of them:

### Exact matching
Provide exact name of the shader (including the path) that you can convert in the attribute. You can:

- Include multiple shaders
   - This allows code re-use for similar shaders
   - Check within the conversion code for specific shader to branch off
 
This is best method to target specific shaders and make sure they're converted as best as they can be.

### Heuristics matching
This method is intended to provide fallback conversion for any shaders that do not have an exact converter for them. If you specify that your converter supports this, you'll need to provide a method that takes the Unity material as input and outputs a "confidence" score for the conversion.

In this code, you can for example look at how many properties your converter recognizes and add point for each. Remove point for ones it doesn't support. 

If you detect anything you would not support at all, return null to indicate you can't convert this material at all.

When converting material the system will first look for an exact match. If none is found, it'll check all converters that support heuristics and then use one that gave it the highest score.

If none gives any score, material will fail to convert.

## Asset Converters
The SDK also has system for converting other types of assets. Those are relatively fixed and don't have a system to dynamically expand those. This is because there's only handful of known asset types that need/can be converted. That is:

- Texture2D's
- Meshes
- AudioClips
- Animations
- Video clips

We accept contributions to those converters - but they must be general and improve the overall conversion.

## Converting the scene
The conversion works by recursively walking the Unity game scene and recreating equivalents on Resonite. There are multiple passes and systems involved in this:

### Phase 1 - scan & update converters
- The scene hierarchy is scanned recursively
- For each Unity component, the SDK will try to find matching converter
- If matching converter is found, it's instantiated. Everything else is ignored.
- Both new & existing converters are updated
  - This will make them add/update/remove Resonite binding components as needed
  - The conversions can also request asset providers for Unity assets (Meshes, Textures, Materials, Audio Clips...)
      - Providers are shared between the same assets - you don't need to worry about caching them
      - Any new conversions are scheduled to happen later to make this pass faster
      - Material converters are invoked & updated in this phase as needed
          - Existing material converters will be updated the first time they're encountered within the conversion task, but not after
          - This is because there's assumption that Unity materials do not change within the conversion pass
          - This is important in this phase, as any newly added binding components will be collected in the next phase
- Converter components & Binding components are ignored
    - Converters will remove the binding components that they attached as part of the conversion
    - Manually attached binding components are left as-is - you can attach them manually if you want them to be there! 

The goal of this phase is to create/update/remove Resonite component bindings to match the Unity components as closely as possible - essentially recreate matching Resonite scene programmatically.

### Phase 2 - collect bindings & send
- The scene hierarchy is scanned recursively again
- For each Resonite binding component, update data is collected
    - The SDK automatically handles newly added bindings vs updated
    - Removed binding components are also tracked & removal message collected
- During update collection, ID's for bindings & members can be allocated if they weren't before
- Any removed GameObjects will collect Slot removal messages
- Collected update data is sent as batch update over ResoniteLink

### Phase 3 - asset conversion & update
If the previous phases scheduled any conversions those are processed in the last phase. 

- Conversions for meshes/textures/audio clips and other "big" assets are done in this phase
- After each individual conversion, a message is sent over ResoniteLink to update the asset provider with the URL of the converted asset
    - This is done so Resonite can do its own processing of this asset as soon as possible, while Unity converts others
    - It's also done for effect - it allows user to watch the scene pop in piece by piece, rather than taking longer to pop all at once
- The system tracks if the assets changed since the last conversion and will re-invoke the conversion in such cases
