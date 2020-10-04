public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return Modulo3Filter.modulo3s(CubeFilter.cubes(xs));
    }
}
