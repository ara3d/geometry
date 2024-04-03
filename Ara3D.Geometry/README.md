#  Ara3D.Geometry

[![NuGet Version](https://img.shields.io/nuget/v/Ara3D.Geometry)](https://www.nuget.org/packages/Ara3D.Geometry)

A C# library of geometric algorithms and data structures. 

## Overview

This library is designed specially for parametric design and procedural geometry creation. 

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

## Primitive Functions 

A number of 