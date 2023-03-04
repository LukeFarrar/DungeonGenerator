# DungeonGenerator
- BinarySpacePartition {Need to add some variance so that it doesn't feel "boxed in". Maybe push the rooms away from larger rooms or move them in a radius}
- Create Volume in leaf nodes {Could use random walk algorithm in each leaf node to make more organic rooms}
- Sort to avoid corridor overlap with rooms
- Simplistic Neighbour search {Need to change the algorithm such as Delaunay triangulation graph then use MST and add a chance to add back the corridor. Add a cost function that makes it cheaper to connect to corridors}
- Create Walls around the volumes

ToDo:
- Create it all in 3 Dimensions
- Add stairs
