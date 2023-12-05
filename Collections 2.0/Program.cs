

using Collections_2._0;

//DICTIONARIES
//Dictionaries - is a generic collection that stores key-value pairs, similar to generic Dictionary<TKey, TValue> collection.

Dictionaries dictionaries = new Dictionaries();
dictionaries.ExecuteDictionaries();

//Characteristics of Dictionary
//1. Dictionary stores key-value pairs.
//2. Comes under System.Collections.Generic namespace.
//3. Implements IDictionary<TKey, TValue> generic interface.
//4. Dictionary<TKey, TValue> class is used to create a dictionary.
//5 Elements are stored as KeyValuePair<TKey, TValue> objects.
//6. Values can be null or duplicate.
//7. Keys should be unique and cannot be null.
//8. Values can be accessed by passing associated key in the indexer e.g. dict[key].
//9. Elements are stored in the unsorted form in Dictionary.
//10. Dictionary is faster than List when it comes to searching by key.
//11. Dictionary is slower than List when it comes to searching by value.





//HASHTABLES
HashTables hashTables = new HashTables();
//hashTables.ExecuteHashtables();

//Hashtables - is a non-generic collection that stores key-value pairs, similar to generic Dictionary<TKey, TValue> collection.

// Characteristics of Hashtable
// 1. Hashtable stores key-value pairs.
// 2. It uses hash-based technique to store key-value pairs.
// 3. It contains unique keys.
// 4. It contains unique values.
// 5. It may have a null key but not null value.
// 6. It is non-generic collection.
// 7. It is defined in System.Collections namespace.
// 8. It implements IDictionary interface.


//Dictionaries VS HashTables
//1. Dictionaries are generic collection while Hashtables are non-generic collection.
//2. Data retrieval is faster in Dictionaries than Hashtables.
//3. Dictionaries are type-safe while Hashtables are not type-safe.
//4. Dictionary is included in System.Collections.Generic namespace while Hashtable is included in System.Collections namespace.

