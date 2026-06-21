# Initial Request

project_name: NeonDrift_MVP
workspace_key: 386b9e33-8429-81f8-a049-ff681ccc7b90
run_id: notion-NeonDrift_MVP-0-12-20260621052900
stage_range: 0-12
agent_model_policy: per-agent-config
legacy_model_field_ignored: per-agent-config
thinking: off
requested_by: define:notion-NeonDrift_MVP-define-20260621052852

## Pipeline Execution Policy

The Notion watcher script is the pipeline controller. Each OpenClaw agent is a worker and uses its own model from openclaw.json. The Notion Model field is not used to route the full pipeline through one model.

## Product Vision and Purpose（產品願景與目的）

NeonDrift MVP is a short-session neon drift racing game used to validate a readable, repeatable mobile gameplay loop before full production and store submission.

## Target Audience（目標受眾）

Mobile players aged 16 to 35 who like fast retries, stylish arcade racing, clear touch controls, visible mastery, and short play sessions.

## Core Value（核心價值）

1. Readable high-speed neon drift gameplay. 2. Immediate retry loop. 3. Production-ready handoffs for spec review, Unity development, privacy, ads, store readiness, and local build monitoring.

## Development Request

Normalize the NeonDrift MVP request before planning. If passed, create a Stage 00-12 planning run from the canonical fields only.

Define source:
- define_run_id: notion-NeonDrift_MVP-define-20260621052852
- define_output_folder: /home/node/.openclaw/workspace/386b9e33-8429-8100-ac9b-ee504f6de1f0/NeonDrift_MVP__define__notion-NeonDrift_MVP-define-20260621052852/project/
- define_handoff_path: /home/node/.openclaw/workspace/386b9e33-8429-8100-ac9b-ee504f6de1f0/NeonDrift_MVP__define__notion-NeonDrift_MVP-define-20260621052852/project/handoffs/define/handoff_to_planning.md

Locked define constraints:
- platform_target: Unity 6000.0.71f1, iOS-first, Android and WebGL as secondary targets, local Unity build only.
- monetization_direction: Rewarded ads first using AdMob; interstitial ads only after retention and user experience review; privacy and store disclosures required.
- compatibility_target: iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro, Android 10+ representative devices, and WebGL desktop browser.
- output_expectation: Define must produce bounded canonical input; Planning must produce Notion-readable docs, Git-published output, and downstream-ready spec review and development handoffs.
