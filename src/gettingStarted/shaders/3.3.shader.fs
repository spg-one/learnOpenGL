#version 330 core
in vec3 positonForNext;
out vec4 FragColor;

uniform vec4 ourColor;

void main()
{
    FragColor = vec4(positonForNext,1.0);
}