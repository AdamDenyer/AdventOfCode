import inputs
import settings
import importlib
import time


def run_day(day):
    package_name = "aoc" + str(settings.year) + ".day" + inputs.two_digit_day(day)
    # Part 1
    start = time.perf_counter_ns()
    part1 = importlib.import_module(package_name).part1(settings.use_examples)
    duration = int((time.perf_counter_ns() - start)/1000)
    print("Day " + day + "-1: " + str(part1) + " (" + str(duration) + "μs)")
    # Part 2
    start = time.perf_counter_ns()
    part2 = importlib.import_module(package_name).part2(settings.use_examples)
    duration = int((time.perf_counter_ns() - start)/1000)
    print("Day " + day + "-2: " + str(part2) + " (" + str(duration) + "μs)")


def run_all(highest_day):
    for day in range(1, int(highest_day) + 1):
        run_day(str(day))


if __name__ == "__main__":
    print('---------------------')
    print(' Advent of Code ' + str(settings.year))
    print('---------------------')
    if settings.run_all:
        run_all(settings.day)
    else:
        run_day(settings.day)
