cmake_minimum_required(VERSION 3.20)
project("test_csharp" CSharp)

set(CMAKE_RUNTIME_OUTPUT_DIRECTORY_DEBUG ${CMAKE_BINARY_DIR}/bin)
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY_RELEASE ${CMAKE_BINARY_DIR}/bin)

add_subdirectory(hello-world)
add_subdirectory(hello-opencv)
