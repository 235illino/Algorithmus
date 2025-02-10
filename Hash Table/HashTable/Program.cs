
using HashTable;

RandomizedSet randomizerSet = new RandomizedSet();


randomizerSet.Insert(3);
randomizerSet.Insert(3);
randomizerSet.GetRandom();
randomizerSet.GetRandom();

randomizerSet.Insert(1);
randomizerSet.Remove(3);
randomizerSet.GetRandom();
randomizerSet.GetRandom();

randomizerSet.Insert(0);
randomizerSet.Remove(0);

