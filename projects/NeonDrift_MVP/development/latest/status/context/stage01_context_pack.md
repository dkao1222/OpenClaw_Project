# Stage 01 Context Pack

project_name: NeonDrift_MVP
channel_id: 382b9e3384298039b171c9b2a60ae644

## project goal

由 Raw Idea 正規化：建立 NeonDrift_MVP，一款 iOS-first Unity 霓虹 arcade drifting 手機遊戲，用來完整驗證 OpenClaw pipeline。
需求必須從 Raw Idea 正規化到 Define，再進 Planning 0-12、Spec Review、Development、Local Unity iOS Simulator Build、QA、Delivery。
Planning 與 Spec Review 必須先規劃遊戲深度與畫面華麗度，不能到 development 才補。必須明確定義 icon、字體、背景、特效、音效、haptics、HUD、按鍵尺寸/位置/safe area、相容性機種與效能目標。
Development 必須產出 Unity

## target audience

由 Raw Idea 推導目標受眾；若原始想法未指定，先假設為 iOS 手機端使用者/玩家，並在 Define 階段標記需驗證。

## core value

由 Raw Idea 提煉 1-3 個核心價值；初始假設是操作/使用流程清楚、短時間可驗證、iOS 交付可測。

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
