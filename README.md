# MenuBuilder v0.1

Menubuilder help you to create in menu list, you can use this on any type application for creating static menu or nagivation bar.

Note:- Integrate permission module  in progress.

```sh
var builder = new MenuBuilder();
builder
.AddLeaf("Leaf 1")
.AddLeaf("Leaf 2")
.AddLeaf("Leaf 3")
.AddBranch("Branch 1")
	.AddLeaf("Leaf 1")
	.AddLeaf("Leaf 2")
	.Bulid()
.AddLeaf("Leaf 4");
```