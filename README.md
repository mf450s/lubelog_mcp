# MCP Server for LubeLogger

This is a technical tool mainly for experimentation and exploration into AI-enabled features in LubeLogger. 

AI and MCP are still an evolving technologies, implementations of this project is subject to be broken without prior notice.

## Pre-requisites
- AI agent with ability to call tools/external integrations(i.e.: Claude Desktop)

Sample Claude Config:

```
{
  "mcpServers": {
    "lubelogger": {
      "command": "npx",
      "args": [
        "mcp-remote",
        "http://localhost:5105/api/mcp"
      ]
    }
  }
}
```
