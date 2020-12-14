# learnOpenGL
my learning of openGL
oneNote link：
https://onedrive.live.com/view.aspx?resid=22CA83506094165C%2130233&id=documents
onenote:https://d.docs.live.net/22ca83506094165c/文档/openGL.SPG/

# how to monitor the Vendor and the Renderer

std::cout << (const char *) glGetString(GL_VERSION) << std::endl;

std::cout << (const char *) glGetString(GL_VENDOR) << std::endl; 

std::cout << (const char *) glGetString(GL_RENDERER) << std::endl;