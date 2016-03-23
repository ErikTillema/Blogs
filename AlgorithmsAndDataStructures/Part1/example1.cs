public static List<string> GetImagesToCopy(string[] source, string[] target) {
	List<string> result = new List<string>();
	foreach (string sourceElement in source) {
		// the lookup: determine whether target contains sourceElement.
		// O(N) because looping over all target elements.
		bool existsInTarget = false;
		foreach (string targetElement in target) {
			if (sourceElement == targetElement) {
				existsInTarget = true;
				break;
			}
		}
		if (!existsInTarget) {
			result.Add(sourceElement);
		}
	}
	return result;
}