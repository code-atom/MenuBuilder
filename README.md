# MenuBuilder
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