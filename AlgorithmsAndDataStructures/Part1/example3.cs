public static List<string> GetImagesToCopy(string[] source, HashSet<string> target) {
	List<string> result = new List<string>();
	foreach (string sourceElement in source) {
		bool existsInTarget = target.Contains(sourceElement); // the lookup: in constant time, O(1).
		if (!existsInTarget) {
			result.Add(sourceElement);
		}
	}
	return result;
}