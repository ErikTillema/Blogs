public static List<string> GetImagesToCopy(string[] source, HashSet<string> target) {
	return source.Where(sourceElement => !target.Contains(sourceElement)).ToList();
}