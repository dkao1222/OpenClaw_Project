# Initial Request

project_name: NeonDrift_MVP
workspace_key: 386b9e33-8429-815b-a8f3-c43fc218eef4
run_id: notion-NeonDrift_MVP-0-12-20260621091857
stage_range: 0-12
agent_model_policy: per-agent-config
legacy_model_field_ignored: per-agent-config
thinking: off
requested_by: define:notion-NeonDrift_MVP-define-20260621091846

## Pipeline Execution Policy

The Notion watcher script is the pipeline controller. Each OpenClaw agent is a worker and uses its own model from openclaw.json. The Notion Model field is not used to route the full pipeline through one model.

## Product Vision and Purpose（產品願景與目的）

NeonDrift is a short-session mobile arcade drifting game. It should solve the pain point of players wanting a fast, readable, one-hand friendly skill game that can be played in under one minute, while creating a reusable Unity MVP pipeline for iOS-first release and later Android/WebGL expansion.

## Target Audience（目標受眾）

Mobile casual and arcade players age 13+, especially commuters and short-break players who like reflex, near-miss, and score-chasing games but dislike long tutorials or complex progression.

## Core Value（核心價值）

One-hand drift control with immediate readable feedback; fast failure and instant retry loop; mobile-safe HUD and compatibility across iPhone SE 2/3, iPhone 15, Android 10+, and WebGL desktop browser.

## Development Request

Run the full OpenClaw game pipeline from Define to Planning stage 0-12, Spec Review, Development, and build handoff. Use local context compressor, split documents, Notion-readable output, Git-ready project output, and local Unity build watcher policy.

Define source:
- define_run_id: notion-NeonDrift_MVP-define-20260621091846
- define_output_folder: /home/node/.openclaw/workspace/386b9e33-8429-81ad-9628-d88a9a0d76f4/NeonDrift_MVP__define__notion-NeonDrift_MVP-define-20260621091846/project/
- define_handoff_path: /home/node/.openclaw/workspace/386b9e33-8429-81ad-9628-d88a9a0d76f4/NeonDrift_MVP__define__notion-NeonDrift_MVP-define-20260621091846/project/handoffs/define/handoff_to_planning.md

Locked define constraints:
- platform_target: Unity 6000.0.71f1, iOS-first, Android and WebGL as secondary targets.
- monetization_direction: Rewarded ads first; interstitial ads only after retention and user experience review. AdMob account is available.
- compatibility_target: iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro, Android 10+ representative devices, WebGL desktop browser.
- output_expectation: Planning must produce bounded Markdown handoffs, Notion-readable documents, Git publish output, and downstream-ready spec review and development handoffs.
