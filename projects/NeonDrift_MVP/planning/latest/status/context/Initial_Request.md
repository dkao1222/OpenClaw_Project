# Initial Request

project_name: NeonDrift_MVP
workspace_key: 385b9e33-8429-8143-b8b3-ef455491bfc7
run_id: notion-NeonDrift_MVP-0-12-20260620165925
stage_range: 0-12
agent_model_policy: per-agent-config
legacy_model_field_ignored: per-agent-config
thinking: off
requested_by: codex-retry-after-stage02-handoff-size-fix

## Pipeline Execution Policy

The Notion watcher script is the pipeline controller. Each OpenClaw agent is a worker and uses its own model from openclaw.json. The Notion Model field is not used to route the full pipeline through one model.

## Product Vision and Purpose（產品願景與目的）

NeonDrift MVP is a short-session neon racing game concept built to validate a fast, readable, repeatable mobile gameplay loop before full production. The planning pipeline must produce documents that can actually feed spec review, Unity development, local build, App Store/Google Play privacy and ads preparation, and future multi-platform expansion.

## Target Audience（目標受眾）

Mobile players aged 16 to 35 who enjoy fast retry loops, stylish arcade racing, clear controls, visible mastery, and short play sessions. Also includes the development team that needs precise planning artifacts small enough for downstream agents to consume without context overflow.

## Core Value（核心價值）

1. Readable high-speed neon drift gameplay with immediate restart. 2. Concrete production-ready planning handoffs with bounded context size. 3. Mobile-first UX, compatibility, monetization, privacy, and store-readiness considerations.

## Development Request

Run the OpenClaw game planning pipeline from Stage 00 through Stage 12 from Notion. Use per-agent model configuration. Enforce strict output/process constraints: BLOCKED, NO_REPLY, handoff failure, heartbeat failure, path truncation, tool error, missing read-back, oversized context, repeated bilingual filler, and generic placeholder content all make the whole run fail. Planning outputs must target Unity 6000.0.71f1 mobile game development, include concrete UI/icon size and icon identity requirements, operation flow with interaction feel, prototype/canvas handoff expectations where applicable, Apple HIG-informed mobile design constraints, and device compatibility considerations.
