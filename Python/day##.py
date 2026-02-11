import inputs


def part1(use_examples):
    filepath = inputs.build_filepath(2000, 0, use_examples)
    int_inputs = inputs.list_ints(filepath, '\n')
    return 0


def part2(use_examples):
    filepath = inputs.build_filepath(2000, 0, use_examples)
    str_inputs = inputs.list_strings(filepath, '\n')
    return 0