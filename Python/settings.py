# Get local file paths from .env file
import os
from dotenv import load_dotenv

load_dotenv()
year = os.getenv("YEAR")
day = os.getenv("DAY")
run_all = os.getenv("RUN_ALL")
use_examples = os.getenv("USE_EXAMPLES")
input_path = os.getenv("INPUT_PATH")
example_dir = os.getenv("EXAMPLE_DIR")
slash = os.getenv("SLASH")