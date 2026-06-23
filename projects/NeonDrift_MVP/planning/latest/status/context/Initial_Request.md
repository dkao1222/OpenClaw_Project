# Initial Request

project_name: NeonDrift_MVP
workspace_key: 382b9e3384298039b171c9b2a60ae644
run_id: notion-NeonDrift_MVP-0-12-20260623145025
stage_range: 0-12
agent_model_policy: per-agent-config
legacy_model_field_ignored: per-agent-config
thinking: off
requested_by: define:notion-NeonDrift_MVP-define-20260623145010

## Pipeline Execution Policy

The Notion watcher script is the pipeline controller. Each OpenClaw agent is a worker and uses its own model from openclaw.json. The Notion Model field is not used to route the full pipeline through one model.

## Product Vision and Purpose（產品願景與目的）

Deliver a fast mobile arcade drift MVP that proves a readable core loop, satisfying neon presentation, meaningful progression hooks, and store-ready iOS delivery path.

## Target Audience（目標受眾）

Mobile casual arcade players on iPhone who want short skill-based sessions, clear controls, quick retry, and polished audiovisual feedback.

## Core Value（核心價值）

1. Clear drift-control loop with readable hazards and scoring. 2. Visually rich neon arcade feedback with motion, effects, audio, and haptics. 3. QA-verifiable iOS simulator/local build path with evidence recording.

## Development Request

Start from Define and let the cron-driven OpenClaw watcher continue the full pipeline through planning, spec review, development, build handoff, and QA readiness. Do not rely on Codex manual project file edits. Build remains not start until Unity local build is manually confirmed.

Raw idea source:
Create an iOS-first Unity arcade drift game MVP. The game must be immediately understandable, visually rich, and deeper than a single-button prototype. Planning, spec review, development, build, and QA must be driven by Notion watcher/cron flow. QA should cover functional gameplay, button interaction, visual clarity, tutorial comprehension, failure/retry loop, and recorded evidence.

Define source:
- define_run_id: notion-NeonDrift_MVP-define-20260623145010
- define_output_folder: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
- define_handoff_path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/define/handoff_to_planning.md

Locked define constraints:
- platform_target: Unity 6000.0.77f1, iOS simulator first, iOS device/App Store later, Android and WebGL secondary.
- monetization_direction: Rewarded ads first; interstitial ads only after retention and user experience review. AdMob account is available.
- compatibility_target: iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro; safe-area, touch targets, reduced motion, and readable contrast required.
- output_expectation: Every pipeline stage must publish to Notion and Git under one project folder, with bounded documents, explicit gates, handoffs, build instructions, QA test plan, QA report, and recorded evidence requirements.
