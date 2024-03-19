namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class PhotonicDeflectors : IPhotonicDeflectors
{
    private const int Limit = 3;

    public int GetLimitAntimatterFlares(IDeflector? deflector)
    {
        if (deflector != null)
        {
            return Limit;
        }

        return 0;
    }

    public int GetLimitAntimatterFlares(int deflector)
    {
        if (deflector == 0)
        {
            return Limit;
        }

        return 0;
    }
}