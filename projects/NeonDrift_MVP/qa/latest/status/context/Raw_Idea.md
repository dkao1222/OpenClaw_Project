# Raw Idea

raw_idea_page_id: 38bb9e33-8429-81f0-b5b1-da471ab98a68
chain_id: raw:NeonDrift_MVP:20260626163656
project_name: NeonDrift_MVP
idea_type: game
target_platform: Unity iOS
priority: high
requested_by: scheduled-agent-chainfix-opdca-kb-clean-retry-20260627

## Raw Idea（原始想法）

Create an iOS-first Unity quick game MVP named NeonDrift_MVP: a neon arcade drift runner where the player pilots a hover car through a moving light tunnel.
The full OpenClaw pipeline must run Raw Idea -> Define -> Planning -> Spec Review -> Development -> Build -> QA without manual product-code intervention.
The player goal is to survive as long as possible, collect boost cells, avoid hazard shards, build combo/near-miss score, and retry quickly for a better best score.
The core gameplay is left/right drift control with visible vehicle movement, track motion, hazard approach, boost pickup, pulse drain, failure reason, pause, and retry.
The game must be visually rich, immediately understandable, and deeper than a single static tap loop: clear objective, movement, scoring, hazards, boost/combo feedback, failure reason, pause, retry, and visible progression hooks.
Planning and Spec Review must define visual richness, gameplay depth, iconography, fonts, background layers, effects, compatibility targets, QA gates, and local iOS simulator delivery before Development starts.
Retry is accepted only when a human can see a clear transition from game-over to a fresh playable run: failure overlay removed, score/timer/run state reset, player/track motion resumes, and the after-retry screenshot/video differs from the game-over frame.
Build must auto-start with Unity 6000.0.77f1 when the licensed local Unity Editor is available. QA must include simulator screenshots, playthrough video, button/touch layout checks, and every core gameplay function check.

## Game Concept（遊戲概念）

Neon arcade drift runner: the player pilots a glowing hover car in a moving light tunnel, making quick left/right drift decisions under pressure.

## Player Goal（玩家目標）

Survive the run, avoid hazard shards, collect boost cells, chain near misses/combo score, and beat the best score with fast retry.

## Core Gameplay（核心玩法）

Tap/hold left or right to drift between lanes while the track scrolls. Hazards damage/end the run, boosts restore pulse and score, and retry must restart a fresh moving run.

## Core Objects（核心物件）

Player hover car, neon track/lane rails, hazard shards, boost cells, score/combo/pulse HUD, pause, failure overlay with reason, retry button.

## Visual Direction（視覺方向）

High-contrast neon arcade style with moving background layers, visible vehicle silhouette, cyan/magenta hazard-reward language, glow trails, readable HUD, and safe-area aware controls.

## Success Criteria（成功條件）

QA must provide screenshots/video proving Start, moving gameplay, left/right control response, hazard, boost, score/pulse change, failure reason, retry reset, visual richness, and non-placeholder style frames.

## Must Have（必須包含）

Start menu, Settings/Sound, best score, left/right touch controls, moving player vehicle, track/background motion, hazards, boosts, score/combo/pulse HUD, pause, failure reason, retry, screenshots, and QA video.

## Must Not（不可包含）

No static empty screen, no flat-color-only background, no placeholder-only squares, no unclear failure, no retry without fresh gameplay state, no QA pass without visual/product evidence.

## Reference（參考資料）

Use OpenClaw knowledge bases for Apple HIG, product experience, game quality, game system design, visual richness, and OpenGameArt-compatible asset direction.

## Monetization Direction（收益方向）

Rewarded ads may be considered only after failure/retry or future revive/bonus flows; ads must not interrupt the first run or core tutorial experience.

## Compatibility Target（相容性目標）

iOS-first Unity 6000.0.77f1, local iOS simulator build, safe-area aware controls, readable on common iPhone portrait screens, performance suitable for mid-range iOS devices.

## QA Requirement（QA 要求）

QA must include simulator screenshots, playthrough video, touch/button checks, every gameplay function check, human visual readability, product experience, style-frame evidence, retry recovery, and build artifacts.
