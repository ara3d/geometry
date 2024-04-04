#  Ara3D.Geometry

[![NuGet Version](https://img.shields.io/nuget/v/Ara3D.Geometry)](https://www.nuget.org/packages/Ara3D.Geometry)

A cross-platform C# library of geometric algorithms and data structures.

![Parametric-Geometry-Toolkit-Teaser](https://github.com/ara3d/geometry/assets/1759994/cd15d3bd-7dd5-4f01-9ca3-a67314a8e0e0)

## Status

This library is a work in progress and still undergoing frequent changes.  

## Overview

This library is designed specially for parametric design and procedural geometry creation. 
Everything is written from the ground in .NET Standard 2.0 compliant C# and has minimal dependencies.
All dependencies are also .NET Standard 2.0 compliant C#. 

* [Ara3D.Mathematics](https://github.com/ara3d/mathematics)
* [Ara3D.Collections](https://github.com/ara3d/collections)
* [Ara3D.Utils](https://github.com/ara3d/utils) 

This library leverages functional programming techniques and a fluent-style API (i.e., method-chain syntax)
to make working with geometric structures easy and efficient. 

Most data structures are immutable. 

## Interfaces

Many of the interfaces are defined in the file `Interfaces.cs`. Some of the primary interface are:

* `ITriMesh` - triangular mesh
* `IQuadMesh` - quadrilateral mesh
* `IPolyLine2D` - a series of connectedline segments 
* `IPolyLine3D` - a series of connected line segments in 3D space
* `ISurface` - a surface in 3D space, that may be discrete or parametric.
* `IParametricSurface` - a surface defined using a mapping from UV coordinates to XYZ coordinates
* `ICurve2D` - a continuous curve in 2D space 
* `ICurve3D` - a continuous curve in 3D space

## Primitive Shapes

A number of primitive shapes are provided in 2D and 3D.

See:

* `PlatonicSolids.cs`
* `ParametricSurfaces.cs`
* `Polygons.cs`
* `Prisms.cs`

## Building the Library from Source 

This library can only be build as a submodule of the [Ara 3D Main Repository](https://github.com/ara3d/ara3d). 



