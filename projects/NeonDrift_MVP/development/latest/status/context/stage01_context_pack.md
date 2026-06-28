# Stage 01 Context Pack

project_name: NeonDrift_MVP
channel_id: 382b9e3384298039b171c9b2a60ae644

## project goal

由 Raw Idea 正規化：Create an iOS-first Unity quick game MVP named NeonDrift_MVP: a neon arcade drift runner where the player pilots a hover car through a moving light tunnel.
The full OpenClaw pipeline must run Raw Idea -> Define -> Planning -> Spec Review -> Development -> Build -> QA without manual product-code intervention.
The player goal is to survive as lo

## target audience

由 Raw Idea 中已提交的概念與平台推導目標受眾；若原始想法未指定，只能標記 open question，不可把預設玩家輪廓當成確定需求。

## core value

由 Raw Idea 提煉 1-3 個核心價值；核心價值必須回指已提交的 game concept/core gameplay/player goal。
核心玩法：Tap/hold left or right to drift between lanes while the track scrolls. Hazards damage/end the run, boosts restore pulse and score, and retry must restart a fresh moving run.
核心物件：Player hover car, neon track/lane rails, hazard shards, boo

## locked decisions

- Notion watcher controls pipeline progression.
- Each downstream OpenClaw agent uses its configured model.
- Unity 6000.0.77f1 mobile direction is locked for planning.

## open questions

- Confirm final device compatibility and store policy details in downstream stages.

## next stage input policy

Read the Stage 01 handoff first, then this context pack. Open source paths only if details are missing.

## source paths

- /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/context/Initial_Request.md
- status/context/Project_Context_Index.md
- status/context/Current_Status_Summary.md
