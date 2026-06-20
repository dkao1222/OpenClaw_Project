# Initial Request

project_name: NeonDrift_MVP
workspace_key: 385b9e33-8429-81ca-80ce-e475781e06b2
run_id: notion-NeonDrift_MVP-0-12-20260620171416
stage_range: 0-12
agent_model_policy: per-agent-config
legacy_model_field_ignored: per-agent-config
thinking: off
requested_by: codex-retry-after-delete-row-deterministic-stage05-12

## Pipeline Execution Policy

The Notion watcher script is the pipeline controller. Each OpenClaw agent is a worker and uses its own model from openclaw.json. The Notion Model field is not used to route the full pipeline through one model.

## Product Vision and Purpose（產品願景與目的）

NeonDrift MVP is a short-session neon racing game concept built to validate a fast, readable, repeatable mobile gameplay loop before full production. Planning outputs must feed spec review, Unity development, local build, App Store and Google Play privacy/ads preparation, and future multi-platform expansion.

## Target Audience（目標受眾）

Mobile players aged 16 to 35 who enjoy fast retry loops, stylish arcade racing, clear controls, visible mastery, and short play sessions. Also includes the development team that needs precise planning artifacts small enough for downstream agents to consume without context overflow.

## Core Value（核心價值）

1. Readable high-speed neon drift gameplay with immediate restart. 2. Concrete production-ready planning handoffs with bounded context size. 3. Mobile-first UX, compatibility, monetization, privacy, and store-readiness considerations.

## Development Request

Run the OpenClaw game planning pipeline from Stage 00 through Stage 12 for NeonDrift MVP. Validate stable handoff, heartbeat, output format, Notion sync, and Git publish. Do not allow spec review or development to start until planning is finished and passed.
