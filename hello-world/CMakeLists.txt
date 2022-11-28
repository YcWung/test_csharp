set(m hello-world)
file(GLOB SRCS *.cs)
add_executable(${m} ${SRCS})
set_property(TARGET ${m} PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.6.1")
