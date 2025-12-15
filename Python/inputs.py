import os
import settings


def build_filepath(year, day, use_examples):
    root_path = str(settings.input_path) + str(year) + str(settings.slash)
    example_dir = str(settings.example_dir) if use_examples else ""
    filename = "Day" + two_digit_day(day) + ".txt"
    filepath = root_path + example_dir + filename
    try:
        os.path.exists(filepath)
    except FileNotFoundError as e:
        raise FileNotFoundError(e)
    else:
        return filepath


def two_digit_day(day):
    # Enforce leading zero on days 1-9 for package and file names
    return "0" + str(day) if len(str(day)) == 1 else str(day)


def list_strings(filepath, separator):
    with open(filepath) as input:
        return list(map(str, input.read().split(separator)))


def list_ints(filepath, separator):
    with open(filepath) as input:
        return list(map(int, input.read().split(separator)))
