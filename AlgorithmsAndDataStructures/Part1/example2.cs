public static List<string> GetImagesToCopy(string[] source, string[] target) {
	return source.Where(sourceElement => !target.Contains(sourceElement)).ToList();
}