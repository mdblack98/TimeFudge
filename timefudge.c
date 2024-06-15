#include <stdio.h>
#include <stdlib.h>
#include <sys/time.h>
#include <math.h>

int main(int argc, char *argv[])
{
    printf("%s v1.0\n", argv[0]);

    if (argc != 2)
    {
        printf("Usage: %s [offset in seconds]\n", argv[0]);
        exit(1);
    }

    double offset;
    sscanf(argv[1], "%lg", &offset);
    printf("Offset=%g\n", offset);
    struct timeval tv;
    int retval = gettimeofday(&tv, NULL);

    if (retval < 0)
    {
        perror("gettimeofday");
    }

    printf("Before offset %ld.%06ld\n", (long)tv.tv_sec, (long)tv.tv_usec);
    long offsetl = offset * 1e6;

    if (offsetl < 0 && tv.tv_usec > labs(offsetl))
    {
        tv.tv_usec += offsetl;
    }
    else if (offsetl < 0)
    {
        tv.tv_sec -= 1;
        tv.tv_usec += 1e6;
        tv.tv_usec += offsetl;
    }
    else
    {
        tv.tv_usec += offsetl;

        if (tv.tv_usec > 1e6)
        {
            tv.tv_sec += 1;
            tv.tv_usec -= 1e6;
        }
    }

    printf("After offset  %ld.%06ld\n", (long)tv.tv_sec, (long)tv.tv_usec);
    retval = settimeofday(&tv, NULL);

    if (retval < 0)
    {
        perror("settimeofday");
    }

    return 0;
}
