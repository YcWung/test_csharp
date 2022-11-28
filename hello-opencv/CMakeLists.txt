set(m hello-opencv)
file(GLOB SRCS *.cs)
add_executable(${m} ${SRCS})
set_property(TARGET ${m} PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.6.1")
set_property(TARGET ${m} PROPERTY VS_PACKAGE_REFERENCES
                                            "OpenCvSharp4.Windows_4.5.3.20211228")
set_property(TARGET ${m} PROPERTY AutoGenerateBindingRedirects true)
